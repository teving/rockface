import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import "rxjs/add/operator/share";

import { LocationProvider } from '../location-provider.service';
import { LocationDetails } from '../location-details.model';

@Component({
   selector: 'rf-location-details',
   templateUrl: 'location-details.component.html'
})
export class LocationDetailsComponent implements OnInit {
   location: Observable<LocationDetails>;

   constructor(private locationProvider: LocationProvider) { }

   ngOnInit(): void {
      this.location = this.locationProvider.getById(1).share();
   }
}
