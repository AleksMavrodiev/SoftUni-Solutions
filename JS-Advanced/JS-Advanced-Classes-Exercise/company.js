class Company{
    constructor(){
        this.departments = {};
    }

    addEmployee(name, salary, position, department){
        if(!name || !salary || !position || !department){
            throw Error("Invalid input!");
        }
        if(!this.departments[department]){
            this.departments[department] = {
                sumSalary: 0,
                avgSalary: 0,
                employees: []
            }
        }

        this.departments[department].employees.push({name, salary, position});
        this.departments[department].sumSalary += salary;
        this.departments[department].avgSalary = this.departments[department].sumSalary / this.departments[department].employees.length;

        return `New employee is hired. Name: ${name}. Position: ${position}`
    }

    bestDepartment(){
        let bestDep = Object.entries(this.departments).sort(([depNameOne, depValueOne], [depNameTwo, depValueTwo]) => depValueTwo.avgSalary - depValueOne.avgSalary)[0];
        let sortedEmployee = bestDep[1].employees.sort((a, b) => {
            return b.salary - a.salary || a.name.localeCompare(b.name);
        });

        let buff = `Best Department is: ${bestDep[0]}\n`;
        buff += `Average salary: ${bestDep[1].avgSalary.toFixed(2)}\n`;
        for(let employee of sortedEmployee){
            buff += `${employee.name} ${employee.salary} ${employee.position}\n`;
        }

        return buff.trim();
    }
}


let c = new Company();
c.addEmployee("Stanimir", 2000, "engineer", "Construction");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());
