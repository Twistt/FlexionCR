import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { Conversion } from '../models/conversion';
import {  } from '../models/global';
@Component({
  selector: 'app-convert-component',
  templateUrl: './convert.component.html'
})
export class ConvertComponent {
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    //We are going to be reusing this for other functions.
    this.httpClient = http;
    this.baseUrl = baseUrl;

    //our initial data load up front (on load) which is our Unit of measures
    http.get<Conversion[]>(baseUrl + 'StaticData').subscribe(result => {
      this.conversions = result;
      this.selectedFromUOM = result[0];
      this.selectedToUOM = result[0];
    }, error => console.error(error));
  }
  private httpClient: HttpClient;
  private baseUrl: string;
  public calculationResult: number;
  public conversions: Conversion[];
  public currentCount = 0;
  public selectedFromUOM: Conversion ;
  public selectedToUOM: Conversion;
  public userValue: number;
  public studentValue: number;
  public incrementCounter() {
    this.currentCount++;
  }
  public calculate() {
    this.userValue = +this.userValue.toFixed(1);
    this.studentValue = +this.studentValue.toFixed(1);
    //string fromUOM, string toUOM, decimal Value
    this.httpClient.get<number>(
      this.baseUrl + 'Conversion?fromUOM=' + this.selectedFromUOM.uom +
      "&toUOM=" + this.selectedToUOM.uom +
      "&value=" + this.userValue).subscribe(result => {
        console.log("Conversion Result:", result);
        this.calculationResult = +result.toFixed(1);
    }, error => console.error(error));
  }
}

//todo: move this to the global level

Array.prototype.where = function (propName, value) {
  var ar = [];
  //console.log(propName, value);
  for (var i = 0; i < this.length; i++) {
    var obj = this[i];
    if (obj.hasOwnProperty(propName)) {
      if (obj[propName] === value) ar.push(obj);
    }
  }
  return ar;
}
