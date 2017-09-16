import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import "rxjs/add/operator/share";
import 'rxjs/add/operator/switchMap';

import { LocationProvider } from '../location-provider.service';
import { LocationDetails } from '../location-details.model';

@Component({
   selector: 'rf-location-details',
   templateUrl: 'location-details.component.html'
})
export class LocationDetailsComponent implements OnInit {
   location: Observable<LocationDetails>;

   constructor(private route: ActivatedRoute, private locationProvider: LocationProvider) { }

   ngOnInit(): void {
      this.location = this.route.params.switchMap(params =>
         this.locationProvider.getById(+params.id)
      ).share();
   }
}
