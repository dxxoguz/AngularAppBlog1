import { Component } from '@angular/core';
import { CategoryModel } from '../models/CategoryModel';
import { UserService } from '../services/userService';
import { PostService } from '../services/postService';
import { BlogPostModel } from '../models/BlogPostModel';



@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['home.css']
})
export class HomeComponent {

  CategoryList: CategoryModel[] = [];
  PostList: BlogPostModel[] = [];
  date = new Date();
  year = this.date.getFullYear();
  month = this.date.getMonth() + 1;
  day = this.date.getDate();
  currentDate: string = ""
  randPost!: BlogPostModel;
  constructor(private userService: UserService, public postService: PostService) {

  }
  ngOnInit(): void {
    this.getCategories();
    this.getPosts();
    this.getRandomPost();
    this.currentDate = `${this.year}.${this.month}.${this.day}`

  }
  getCategories() {
    return this.userService.getCategories().then(res => this.CategoryList = res as CategoryModel[]);
  }
  getPosts() {
   this.postService.getPosts(1,4);
  }

  getClickedPost(id:number) {
    this.postService.getClickedPost(id);
  }
  getCategoryPosts(id: number) {
    this.postService.getPosts(1, 4, id)
    this.postService.categoryPost = this.postService.categoryPost;
  }
  getRandomPost() {
    this.postService.getRandomPost().then(res => this.randPost = res as BlogPostModel);
  }
}




