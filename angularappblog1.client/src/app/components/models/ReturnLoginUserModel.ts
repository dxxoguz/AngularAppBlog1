import { LoginUser } from "./LoginUser";
import { UserModel } from "./UserModel";

export class ReturnLoginUserModel {
  id!: number;
  loginUser!: UserModel;
  token!: string;
}
