import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { RegisterComponent } from './components/authentication/register/register.component';
import { LoginComponent } from './components/authentication/login/login.component';
import { PostPageComponent } from './components/postPage/postPage.component';
import { SupportComponent } from './components/support/support.component';
import { ContactComponent } from './components/contact/contact.component';
import { IndictinationComponent } from './components/indicnation/indictination.component';
import { LoginGuard } from './components/authentication/login/login.guard';
import { AboutUsComponent } from './components/aboutUs/aboutUs.component';
import { UserSettingsComponent } from './components/user/UserSettings/userSettings.component';
import { UserAccountComponent } from './components/user/UserAccount/userAccount.component';
import { SearchedPostsComponent } from './components/searchedPosts/searchedPosts.component';
import { PostComponent } from './components/post/PostComponent';


const routes: Routes = [
  { path: "", component: HomeComponent },
  { path: "topic", component: PostPageComponent,/* canActivate: [LoginGuard] */},
  { path: "login", component: LoginComponent },
  { path: "register", component: RegisterComponent },
  { path: "contact", component: ContactComponent },
  { path: "support", component: SupportComponent },
  { path: "indictination", component: IndictinationComponent },
  { path: "aboutus", component: AboutUsComponent },
  { path: "userSet", component: UserSettingsComponent },
  { path: "userAcc", component: UserAccountComponent },
  { path: "searchRes", component: SearchedPostsComponent },
  { path: "post", component: PostComponent }



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
