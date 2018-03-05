import { Component,OnInit,PipeTransform, Pipe  } from '@angular/core';
import { NgForOf, NgIf } from '@angular/common';

import { DataService } from './data.service';
import { Electricity } from './models/electricity.model';
import { Heat } from './models/heat.model';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{

  heatItems: Heat;
  electricityItems: Electricity;
  buildingType: Array<string> = ["Other","Flat","House"];

  constructor(  private dataService: DataService,) { }

  ngOnInit() {

    this.dataService.getHeatContracts()
    .subscribe(data => {
      this.heatItems = data;
    });

    this.dataService.getElectricityContracts()
    .subscribe(data => {
      console.log(data);
      this.electricityItems = data;
    });

  }
}
