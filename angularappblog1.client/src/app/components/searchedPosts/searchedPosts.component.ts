import { Component } from '@angular/core';
import { CategoryModel } from '../models/CategoryModel';
import { UserService } from '../services/userService';
import { BlogPostModel } from '../models/BlogPostModel';
import { PostService } from '../services/postService';



@Component({
  selector: 'app-searchedPosts',
  templateUrl: './searchedPosts.component.html',
  styleUrls: ['searchedPosts.css']
})
export class SearchedPostsComponent {
  Categories: CategoryModel[] = [];
  postModel = new BlogPostModel;
  constructor(private userService: UserService, public postService: PostService) {
  }
  ngOnInit(): void {

  }

  getClickedPost(id: number) {
    this.postService.getClickedPost(id);
  }

}

