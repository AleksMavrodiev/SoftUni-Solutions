#include<stdio.h>
#include<windows.h>
#define SIZE 100

struct threadinfo {
	int index;
	HANDLE h;
	DWORD tid;
};

HANDLE mutex_r;
HANDLE m1;
HANDLE se;
HANDLE se2;
HANDLE m2;
int buffer[SIZE];

int random_num() {
	int n;
	WaitForSingleObject(mutex_r, INFINITE);
	n = rand() % 1000000 + 1;
	ReleaseMutex(mutex_r);
	return n;
}

DWORD WINAPI prod_thread_func(void* p) {
	threadinfo* p1 = (threadinfo*)p;
	printf_s("\nProducer thread %d started", p1->index);

	for (; ;) {
		int i;
		Sleep((random_num() % 5000) + 5000);
		int n = (rand() % 1000) + 1;
		WaitForSingleObject(se, INFINITE);
		WaitForSingleObject(m1, INFINITE);
		for (i = 0; buffer[i] != 0; i++);
		buffer[i] = n;
		printf_s("\nProducer thread %d buffer[%d] = %d", p1->index, i, n);


		ReleaseMutex(m1);
		ReleaseSemaphore(se2, 1, NULL);

	}


	printf_s("\nThread %d terminated", p1->index);
	return 0;
}

DWORD WINAPI cons_thread_func(void* p)
{
	threadinfo* p1 = (threadinfo*)p;
	printf("\nProducer thread %d started", p1->index);

	for (; ;) {
		Sleep((rand() % 5000) + 5000);
		int i;
		int a;
		WaitForSingleObject(se2, INFINITE);
		WaitForSingleObject(m2, INFINITE);
		for (i = 0; buffer[i] == 0; i++);
		a = buffer[i];
		printf_s("\nConsumer thread %d buffer[%d] = %d", p1->index, i, a);
		buffer[i] = 0;

		ReleaseMutex(m2);
		ReleaseSemaphore(se, 1, NULL);
	}


	printf_s("\nThread %d terminated", p1->index);
	return 0;
}



int main() {

	int n, m;
	printf_s("Enter the number of consumer threads: ");
	scanf_s("%d", &n);

	printf_s("\nEnter the number of consumer threads: ");
	scanf_s("%d", &m);

	threadinfo* arr_of_cons_threads = (threadinfo*)malloc(sizeof(threadinfo) * n);
	threadinfo* arr_of_prod_threads = (threadinfo*)malloc(sizeof(threadinfo) * m);

	m1 = CreateMutex(NULL, FALSE, NULL);
	m2 = CreateMutex(NULL, FALSE, NULL);
	mutex_r = CreateMutex(NULL, FALSE, NULL);

	se = CreateSemaphore(NULL, SIZE, SIZE, NULL);
	se2 = CreateSemaphore(NULL, 0, SIZE, NULL);


	for (int i = 0; i < n; i++) {
		arr_of_cons_threads[i].h = CreateThread(NULL, 0, cons_thread_func, arr_of_cons_threads + i, CREATE_SUSPENDED, &arr_of_cons_threads[i].tid);
		arr_of_cons_threads[i].index = i;
	}

	for (int i = 0; i < m; i++) {
		arr_of_prod_threads[i].h = CreateThread(NULL, 0, prod_thread_func, arr_of_prod_threads + i, CREATE_SUSPENDED, &arr_of_prod_threads[i].tid);
		arr_of_prod_threads[i].index = i;
	}

	ZeroMemory(buffer, sizeof(int) * SIZE);

	for (int i = 0; i < n; i++) {
		ResumeThread(arr_of_cons_threads[i].h);
	}

	for (int i = 0; i < m; i++) {
		ResumeThread(arr_of_prod_threads[i].h);
	}
	system("pause");

	ExitThread(0);
}
