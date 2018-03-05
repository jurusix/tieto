import { Injectable } from '@angular/core';
import { HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';

import { ApiService } from './api.service';
import { Electricity } from './models/electricity.model';
import { Heat } from './models/heat.model';
import { map } from 'rxjs/operators';

@Injectable()
export class DataService {

  constructor(private apiService: ApiService) { }

  getHeatContracts(): Observable<Heat> {
    return this.apiService.get('/contract/getheat')
      .pipe(map(data => data.Items));
  }

  getElectricityContracts(): Observable<Electricity> {
    return this.apiService.get('/contract/getelectricity')
      .pipe(map(data => data.Items));
  }

}
