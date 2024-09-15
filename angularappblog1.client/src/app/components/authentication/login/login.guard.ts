import { Injectable, ɵNOT_FOUND_CHECK_ONLY_ELEMENT_INJECTOR } from "@angular/core";
import { ActivatedRouteSnapshot, CanActivate, GuardResult, MaybeAsync, Router, RouterStateSnapshot } from "@angular/router";
import { AccountService } from "../../services/accountService";
@Injectable()
export class LoginGuard implements CanActivate {

  constructor(private accountService: AccountService, private router: Router) { }
  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): MaybeAsync<GuardResult> {
    let logged = this.accountService.isLoggedIn();
    if (logged) {
      return true;
    } else {
      this.router.navigate(["login"]);
      return false;
    }
  }



}
