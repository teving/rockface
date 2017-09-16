import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { LocationListComponent } from './problem/location/location-list-component/location-list.component';

const appRoutes: Routes = [
   { path: '', redirectTo: '/locations', pathMatch: 'full' },
   { path: '**', redirectTo: '/locations' }
];

@NgModule({
   imports: [
      RouterModule.forRoot(appRoutes)
   ],
   exports: [
      RouterModule
   ]
})
export class AppRoutingModule { }
