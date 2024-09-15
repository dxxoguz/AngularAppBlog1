import { Component } from '@angular/core';
import { CategoryModel } from '../models/CategoryModel';
import { UserService } from '../services/userService';
import { BlogPostModel } from '../models/BlogPostModel';
import { PostService } from '../services/postService';



@Component({
  selector: 'app-addPost',
  templateUrl: './addPost.component.html',
  styleUrls: ['addPost.css']
})
export class AddPostComponent {
  Categories: CategoryModel[] = [];
  blogModel = new BlogPostModel;
  constructor(private userService: UserService, private postService: PostService) {
  }
  ngOnInit(): void {
    this.getCategories();

  }
  getCategories() {
    this.userService.getCategories().then(res => this.Categories = res as CategoryModel[])
  }
  submitForm() {
    this.postService.AddBlogPost(this.blogModel).then(res => console.log(res));
  }

}

