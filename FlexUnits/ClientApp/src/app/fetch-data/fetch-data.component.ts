import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Conversion } from '../models/conversion';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public conversions: Conversion[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Conversion[]>(baseUrl + 'StaticData').subscribe(result => {
      console.log(result);
      this.conversions = result;
    }, error => console.error(error));
  }
}
