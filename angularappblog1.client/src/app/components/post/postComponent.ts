import { Component } from '@angular/core';
import { PostService } from '../services/postService';
import { BlogPostModel } from '../models/BlogPostModel';




@Component({
    selector: 'app-post',
    templateUrl: './post.component.html',
    styleUrls: ['post.css']
})
export class PostComponent {
  postModel!:BlogPostModel
    constructor(public postService: PostService) {
    }
  ngOnInit(): void {


    }


}
