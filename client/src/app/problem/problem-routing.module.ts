import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { LocationListComponent } from './location/location-list-component/location-list.component';
import { LocationDetailsComponent } from './location/location-details-component/location-details.component';

const problemRoutes: Routes = [
   { path: 'locations', component: LocationListComponent },
   { path: 'location/:id', component: LocationDetailsComponent },
];

@NgModule({
   imports: [
      RouterModule.forChild(problemRoutes)
   ],
   exports: [RouterModule]
})
export class ProblemRoutingModule { }
