import { User } from "../models/user.model";

export class UserService{
    users:User[];
    /**
     *
     */
    constructor() {
      this.users = [
          new User("ramu","1234"),
          new User("somu","4321")
      ];
        
    }
    userLogin(user:User){
        for (let index = 0; index < this.users.length; index++) {
            if(this.users[index].username==user.username && this.users[index].password==user.password)
            {
                return true;
            }
        }
        return false;
    }
}