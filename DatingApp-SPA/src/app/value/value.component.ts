import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  // alt + o to go to the template
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {

  values : any;
  URL = 'http://localhost:5000/api/values';

  constructor(private http:HttpClient) { }

  ngOnInit() {
    this.getValues();
  }

  getValues (){
    this.http.get(this.URL).subscribe(response=>{
      this.values = response;
    }, error => console.log(error));
  }

}
