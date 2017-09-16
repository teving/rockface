import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { LocationListComponent } from './location/location-list-component/location-list.component';

const problemRoutes: Routes = [
   { path: 'locations', component: LocationListComponent }
];

@NgModule({
   imports: [
      RouterModule.forChild(problemRoutes)
   ],
   exports: [RouterModule]
})
export class ProblemRoutingModule { }
