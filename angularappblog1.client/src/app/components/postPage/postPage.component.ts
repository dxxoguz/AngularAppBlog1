import { Component } from '@angular/core';
import { PostService } from '../services/postService';
import { BlogPostModel } from '../models/BlogPostModel';



@Component({
  selector: 'app-postPage',
  templateUrl: './postPage.component.html',
  styleUrls: ['postPage.css']
})
export class PostPageComponent {
  pageCount:number=0
  pageNumber = 1
  perPage=4
  date = new Date();
  year = this.date.getFullYear();
  month = this.date.getMonth() + 1;
  day = this.date.getDate();
  currentDate: string = ""
  constructor(public postService: PostService) { }
  ngOnInit(): void {
    this.currentDate = `${this.year}.${this.month}.${this.day}`
    this.getPosts(this.pageNumber, this.perPage)
  }
  getPosts(pageNumber: number, perPage: number) {
    this.postService.getPosts(this.pageNumber, this.perPage)
  }
  get pageNumbers(): number[] {
    return Array(Math.ceil(this.postService.totalCount / this.perPage)).fill(0).map((p, i) => i + 1);
  }


  changePage(page: number) {
    if (this.pageNumber == 1) {
      const prevButton = document.getElementById("prev") as HTMLButtonElement
      prevButton.disabled = true;
    }
    if (this.pageNumber == this.postService.postList.length) {
      const nextButton = document.getElementById("next") as HTMLButtonElement
      nextButton.disabled = true;
    }
    this.pageNumber = page
    this.getPosts(this.pageNumber, this.perPage)
    console.log(this.pageNumber)
  }
  getClickedPost(id: number) {
    this.postService.getClickedPost(id);
  }
}


