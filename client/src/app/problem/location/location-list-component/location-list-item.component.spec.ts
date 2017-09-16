import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { NO_ERRORS_SCHEMA } from '@angular/core';
import { By } from '@angular/platform-browser';

import { LocationListItem } from '../location-list-item.model';
import { LocationListItemComponent } from './location-list-item.component';

describe('LocationListItemComponent', () => {
   beforeEach(async(() => {
      TestBed.configureTestingModule({
         declarations: [LocationListItemComponent],
         schemas: [ NO_ERRORS_SCHEMA ]
      }).compileComponents();
   }));

   beforeEach(() => {
      this.fixture = TestBed.createComponent(LocationListItemComponent);
      this.component = this.fixture.componentInstance;
   });

   describe('onInit', () => {
      beforeEach(() => {
         this.component.location = {
            id: 1,
            name: 'Climbing Centre'
         };
         this.fixture.detectChanges();
      });

      it('should create a link showing the location name', () => {
         const link = this.fixture.debugElement.query(By.css('a'));
         expect(link.nativeElement.textContent).toBe('Climbing Centre');
      });
   });
});
