//import Equipments from "./equipments_combo";
import BtnHandler from "./main";
function TSButton() {
    //let name: string = "Fred";
    //document.getElementById("ts-example").innerHTML = greeter(user);
    BtnHandler();
}
class Student {
    firstName;
    middleInitial;
    lastName;
    fullName;
    constructor(firstName, middleInitial, lastName) {
        this.firstName = firstName;
        this.middleInitial = middleInitial;
        this.lastName = lastName;
        this.fullName = firstName + " " + middleInitial + " " + lastName;
    }
}
function greeter(person) {
    return "Hello, " + person.firstName + " " + person.lastName;
}
let user = new Student("Fred", "M.", "Smith");
