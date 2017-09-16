import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { Observable } from 'rxjs';

import { LocationProvider } from '../location-provider.service';
import { LocationListItem } from '../location-list-item.model';
import { LocationListComponent } from './location-list.component';
import { LocationListItemComponent } from './location-list-item.component';

describe('LocationListComponent', () => {
   beforeEach(async(() => {
      this.locationProvider = {
         getAll(): Observable<LocationListItem[]> { return Observable.of([]); }
      };

      TestBed.configureTestingModule({
         providers: [{ provide: LocationProvider, useValue: this.locationProvider }],
         declarations: [
            LocationListComponent,
            LocationListItemComponent
         ]
      }).compileComponents();
   }));

   beforeEach(() => {
      this.fixture = TestBed.createComponent(LocationListComponent);
      this.component = this.fixture.componentInstance;
      this.fixture.detectChanges();
   });

   describe('onInit', () => {
      it('should create a LocationListItem component for each location', () => {
         const locations = [{}, {}, {}];
         const locationProvider = this.fixture.debugElement.injector.get(LocationProvider);
         spyOn(locationProvider, 'getAll').and.returnValue(Observable.of(locations));

         this.component.ngOnInit();
         this.fixture.detectChanges();

         const childComponents = this.fixture.debugElement.queryAll(By.directive(LocationListItemComponent));
         expect(childComponents.length).toBe(3);
      });
   });
});
