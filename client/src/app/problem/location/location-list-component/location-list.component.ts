import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

import { LocationProvider } from '../location-provider.service';
import { LocationListItem } from '../location-list-item.model';

@Component({
   selector: 'rf-location-list',
   templateUrl: './location-list.component.html',
   styleUrls: ['./location-list.component.css']
})
export class LocationListComponent implements OnInit {
   locations: Observable<LocationListItem[]>;

   constructor(private locationProvider: LocationProvider) { }

   ngOnInit() {
      this.locations = this.locationProvider.getAll();
   }
}
