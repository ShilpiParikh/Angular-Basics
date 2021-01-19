import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class InfoServiceService {

  constructor(private http: HttpClient) { }
  private url = "./assets/data.json";

getProduct() {
 return this.http.get(this.url);
}

addProduct(post : any) {
 return this.http.post(this.url, JSON.stringify(post))
}
// updatePost(post){
//  return this.http.patch(this.url + '/' + post.id, JSON.stringify({ isRead: true }))
// }

// deletePost(id) {
//  return this.http.delete(this.url + '/' + id);
// }
// }
}



