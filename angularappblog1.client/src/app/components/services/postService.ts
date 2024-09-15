
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core'
import { BlogPostModel } from '../models/BlogPostModel';
import { Router } from '@angular/router';



@Injectable({
  providedIn: 'root'
})

export class PostService {

  apiUrl = "https://localhost:7120"
  /* apiUrl = "https://localhost:7120 http://localhost:5290 " */
  postList: BlogPostModel[] = [];
  clickedModel!: BlogPostModel;
  searchedPosts: BlogPostModel[] = [];
  searchMessage: string = "";
  totalCount: number = 0;
  categoryPost: BlogPostModel[] = []


  constructor(private http: HttpClient, private router: Router) { }


  getPosts(pageNumber: number, perPage: number, categoryId: number = 0) {
    return this.http.get(this.apiUrl + `/Topic/GetPosts?pageNumber=${pageNumber}&perPage=${perPage}&categoryId=${categoryId}`).subscribe(res => {
      this.postList = res as BlogPostModel[]; this.totalCount = this.postList.length; console.log(this.totalCount)
    });
  }
  AddBlogPost(blogPostMod: BlogPostModel) {
    console.log(blogPostMod)
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.http.post<BlogPostModel>(`${this.apiUrl}/Topic/AddBlogPost`, blogPostMod, { headers: headers }).toPromise();
  }
  getRandomPost() {
    return this.http.get<BlogPostModel>(this.apiUrl + "/Topic/GetRandomPost").toPromise();
  }

  getClickedPost(blogId: number) {
    console.log(blogId)
    var clickedPost = this.postList.find(v => v.id == blogId) as BlogPostModel
    console.log(clickedPost)
    this.clickedModel = clickedPost;
    this.router.navigate(['post']);
  }

}



