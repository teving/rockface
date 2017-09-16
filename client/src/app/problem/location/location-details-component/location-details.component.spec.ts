import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { ActivatedRoute, Params } from '@angular/router';
import { NO_ERRORS_SCHEMA } from '@angular/core';
import { By } from '@angular/platform-browser';
import { Observable } from 'rxjs';

import { LocationProvider } from '../location-provider.service';
import { LocationListItem } from '../location-list-item.model';
import { LocationDetailsComponent } from './location-details.component';
import { CircuitSummaryComponent } from './circuit-summary.component';

describe('LocationDetailsComponent', () => {
   beforeEach(async(() => {
      const locationProvider = {
         getById(id: number): Observable<LocationDetailsComponent> { return Observable.empty(); }
      };
      const activatedRoute = {
         params: Observable.of({})
      };

      TestBed.configureTestingModule({
         providers: [
            { provide: LocationProvider, useValue: locationProvider },
            { provide: ActivatedRoute, useValue: activatedRoute }
         ],
         declarations: [
            LocationDetailsComponent,
            CircuitSummaryComponent
         ],
         schemas: [NO_ERRORS_SCHEMA]
      }).compileComponents();
   }));

   beforeEach(() => {
      this.fixture = TestBed.createComponent(LocationDetailsComponent);
      this.component = this.fixture.componentInstance;

      this.locationProvider = this.fixture.debugElement.injector.get(LocationProvider);
      this.activatedRoute = this.fixture.debugElement.injector.get(ActivatedRoute);
   });

   describe('onInit', () => {
      it('should get the location from the provider using the route id', () => {
         this.activatedRoute.params = Observable.of({ id: '1' });
         spyOn(this.locationProvider, 'getById').and.callThrough();

         this.component.ngOnInit();
         this.fixture.detectChanges();

         expect(this.locationProvider.getById).toHaveBeenCalledWith(1);
      });

      describe('when the location has been returned', () => {
         beforeEach(() => {
            const location = {
               name: 'Climbing Centre',
               circuits: [{}, {}, {}]
            }
            spyOn(this.locationProvider, 'getById').and.returnValue(Observable.of(location));

            this.component.ngOnInit();
            this.fixture.detectChanges();
         });

         it('should display the location name in a header', () => {
            const header = this.fixture.debugElement.query(By.css('h2'));
            expect(header.nativeElement.textContent).toBe('Climbing Centre');
         });

         it('should create a CircuitSummary component for each circuit', () => {
            const childComponents = this.fixture.debugElement.queryAll(By.directive(CircuitSummaryComponent));
            expect(childComponents.length).toBe(3);
         });
      });
   });
});
