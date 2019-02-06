class Employee {
    constructor(firstName, lastName, salary) {
        this.firstName = firstName || '';
        this.lastName = lastName || '';
        this.salary = salary || 0;
    }

    increaseSalary() {
        this.salary += 1000;
    }

    displayDetails() {
        console.log(this);

        return JSON.stringify(this);
    }
}