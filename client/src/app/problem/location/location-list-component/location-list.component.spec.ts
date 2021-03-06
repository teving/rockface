import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { NO_ERRORS_SCHEMA } from '@angular/core';
import { By } from '@angular/platform-browser';
import { Observable } from 'rxjs';

import { LocationProvider } from '../location-provider.service';
import { LocationListItem } from '../location-list-item.model';
import { LocationListComponent } from './location-list.component';
import { LocationListItemComponent } from './location-list-item.component';

describe('LocationListComponent', () => {
   beforeEach(async(() => {
      const locationProvider = {
         getAll(): Observable<LocationListItem[]> { return Observable.of([]); }
      };

      TestBed.configureTestingModule({
         providers: [{ provide: LocationProvider, useValue: locationProvider }],
         declarations: [
            LocationListComponent,
            LocationListItemComponent
         ],
         schemas: [ NO_ERRORS_SCHEMA ]
      }).compileComponents();
   }));

   beforeEach(() => {
      this.fixture = TestBed.createComponent(LocationListComponent);
      this.component = this.fixture.componentInstance;
   });

   describe('onInit', () => {
      beforeEach(() => {
         this.locations = [{}, {}, {}];
         const locationProvider = this.fixture.debugElement.injector.get(LocationProvider);
         spyOn(locationProvider, 'getAll').and.returnValue(Observable.of(this.locations));

         this.component.ngOnInit();
         this.fixture.detectChanges();
      });

      it('should create a LocationListItem component for each location', () => {
         const childComponents = this.fixture.debugElement.queryAll(By.directive(LocationListItemComponent));
         expect(childComponents.length).toBe(3);
      });
   });
});
