#include<stdio.h>
#include<windows.h>

HANDLE globalh;
int count = 0;
HANDLE mutex;

struct threadinfo {
	int index;
	HANDLE h;
	DWORD tid;
};

DWORD WINAPI thread_func(void* p) {
	threadinfo* p1 = (threadinfo*)p;
	printf_s("\nthread %d started", p1->index);

	for (int j = 0; j < 100 * 10; j++) {
		WaitForSingleObject(mutex, INFINITE);
		globalh = p1->h;

		for (int i = 0; i < 100 * 50; i++) {

		}

		if (globalh != p1->h); {
			count++;
		}
		ReleaseMutex(mutex);
	}
	printf_s("\nthread %d terminated", p1->index);
	return 0;
}

int main() {
	int n;

	printf_s("Enter the number of threads: ");
	scanf_s("%d", &n);

	mutex = CreateMutex(NULL, FALSE, NULL);

	threadinfo* arr_of_threads = (threadinfo*)malloc(sizeof(threadinfo) * n);
	for (int i = 0; i < n; i++) {
		arr_of_threads[i].h = CreateThread(NULL, 0, thread_func, arr_of_threads + i, CREATE_SUSPENDED, &arr_of_threads[i].tid);
		arr_of_threads[i].index = i;
	}

	for (int i = 0; i < n; i++) {
		ResumeThread(arr_of_threads[i].h);
	}

	system("pause");

	printf_s("\nThe value of count is: %d ", count);

	ExitThread(0);
}
