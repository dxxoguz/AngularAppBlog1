import { Component } from '@angular/core';
import { CategoryModel } from '../models/CategoryModel';
import { UserService } from '../services/userService';
import { AccountService } from '../services/accountService';
import { PostService } from '../services/postService';
import { BlogPostModel } from '../models/BlogPostModel';
import { Router } from '@angular/router';



@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['nav.css']
})
export class NavComponent {


  constructor(public accountService: AccountService, public postService: PostService, private router: Router) {

  }


  ngOnInit(): void {


  }
  logOut() {

    this.accountService.logOut();
  }
  searchBlogPost(event: Event) {
    var target = event.target as HTMLInputElement;
    var keyword = target.value;
    console.log(keyword);

    if (keyword != "") {
      var keywordLower = keyword.toLowerCase();
      var newList = this.postService.postList.filter(b =>
        (b.title?.toLowerCase().includes(keywordLower)) ||
        (b.content?.toLowerCase().includes(keywordLower))
      );

      this.postService.searchedPosts = newList;
    } else {
      this.postService.searchedPosts = [];
    }


    if (this.postService.searchedPosts) {
      this.postService.searchMessage = `${this.postService.searchedPosts.length} are found`;
      this.router.navigate(['searchRes']);
    } else {
      this.postService.searchMessage = `no post is found`;
    }

  }

}


