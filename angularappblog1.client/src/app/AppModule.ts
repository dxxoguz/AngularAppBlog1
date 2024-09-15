import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { CommentsComponent } from './components/comments/comments.component';
import { RegisterComponent } from './components/authentication/register/register.component';
import { LoginComponent } from './components/authentication/login/login.component';
import { UserService } from './components/services/userService';
import { CommentService } from './components/services/commentService';
import { NavComponent } from './components/nav/nav.component';
import { PostPageComponent } from './components/postPage/postPage.component';
import { AddPostComponent } from './components/addPost/addPost.component';
import { IndictinationComponent } from './components/indicnation/indictination.component';
import { SupportComponent } from './components/support/support.component';
import { ContactComponent } from './components/contact/contact.component';
import { AccountService } from './components/services/accountService';
import { LoginGuard } from './components/authentication/login/login.guard';
import { AboutUsComponent } from './components/aboutUs/aboutUs.component';
import { UserAccountComponent } from './components/user/UserAccount/userAccount.component';
import { UserSettingsComponent } from './components/user/UserSettings/userSettings.component';
import { AuthInterceptor } from './components/services/interceptor/auth.interceptor';
import { SearchedPostsComponent } from './components/searchedPosts/searchedPosts.component';
import { PostComponent } from './components/post/PostComponent';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    RegisterComponent,
    LoginComponent,
    CommentsComponent,
    NavComponent,
    PostPageComponent,
    AddPostComponent,
    IndictinationComponent,
    SupportComponent,
    ContactComponent,
    AboutUsComponent,
    UserAccountComponent,
    UserSettingsComponent,
    SearchedPostsComponent,
    PostComponent

  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule, FormsModule, ReactiveFormsModule
  ],
  providers: [CommentService, UserService, AccountService, LoginGuard, AuthInterceptor],
  bootstrap: [AppComponent]
})
export class AppModule {
}
