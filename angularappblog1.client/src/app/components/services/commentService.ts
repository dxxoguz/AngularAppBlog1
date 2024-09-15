
import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core'



@Injectable({
  providedIn: 'root'
})

export class CommentService {

  apiUrl = "http://localhost:5290";  //https://localhost:7120;

  constructor(private http: HttpClient) { }

  addComment(comment: Comment) {
    this.http.post(this.apiUrl + '/Comment/AddComment', comment)
  }

}



