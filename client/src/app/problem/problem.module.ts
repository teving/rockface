import { NgModule } from '@angular/core';

import { SharedModule } from '../shared/shared.module';
import { ProblemRoutingModule } from './problem-routing.module';

import { LocationProvider } from './location/location-provider.service';
import { LocationListComponent } from './location/location-list-component/location-list.component';
import { LocationListItemComponent } from './location/location-list-component/location-list-item.component';
import { LocationDetailsComponent } from './location/location-details-component/location-details.component';
import { CircuitSummaryComponent } from './location/location-details-component/circuit-summary.component';

@NgModule({
   imports: [
      SharedModule,
      ProblemRoutingModule
   ],
   providers: [LocationProvider],
   declarations: [
      LocationListComponent,
      LocationListItemComponent,
      LocationDetailsComponent,
      CircuitSummaryComponent
   ],
   exports: [LocationListComponent]
})
export class ProblemModule { }
