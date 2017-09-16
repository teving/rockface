import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { LocationConfig } from '../../core/config/location.config';
import { LocationListItem } from './location-list-item.model';

@Injectable()
export class LocationProvider {
   constructor(private config: LocationConfig, private http: HttpClient) { }

   getAll(): Observable<LocationListItem[]> {
      return this.http.get<LocationListItem[]>(this.config.url);
   }
}
