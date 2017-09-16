import { Component, NgModule, Optional, SkipSelf } from '@angular/core';
import { async, TestBed } from '@angular/core/testing';

import { throwIfAlreadyLoaded } from './module-import-guard';

describe('module-import-guard', () => {
   describe('throwIfAlreadyLoaded', () => {
      describe('when parentModule is null', () => {
         it('should not throw', () => {
            expect(() => throwIfAlreadyLoaded(null, 'myModule'))
               .not.toThrow();
         });
      });

      describe('when parentModule is not null', () => {
         it('should throw', () => {
            expect(() => throwIfAlreadyLoaded({}, 'myModule'))
               .toThrowError(Error, 'myModule has already been loaded. Import Core modules in the AppModule only.');
         });
      });
   });
});
