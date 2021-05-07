import { Url } from "url";

export class Customer{
    id:number;
    name:string;
    age:number;
    pic:Url;

    constructor(id?,name?,age?,pic?) {
        this.id=id;
        this.name = name;
        this.age = age;
        this.pic = pic;
    }
}