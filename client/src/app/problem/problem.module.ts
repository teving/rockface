import { NgModule } from '@angular/core';

import { SharedModule } from '../shared/shared.module';
import { ProblemRoutingModule } from './problem-routing.module';

import { LocationProvider } from './location/location-provider.service';
import { LocationListComponent } from './location/location-list-component/location-list.component';
import { LocationListItemComponent } from './location/location-list-component/location-list-item.component';

@NgModule({
   imports: [
      SharedModule,
      ProblemRoutingModule
   ],
   providers: [LocationProvider],
   declarations: [
      LocationListComponent,
      LocationListItemComponent
   ],
   exports: [LocationListComponent]
})
export class ProblemModule { }
