import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

import { LocationProvider } from './location-provider.service';

describe('LocationProvider', () => {
   beforeEach(() => {
      this.config = {
         url: 'http://url'
      };
      this.http = <HttpClient>{
         get(url: string) { return Observable.empty(); }
      };
   });

   describe('getAll', () => {
      it('should call to the locations URL', () => {
         const target = new LocationProvider(this.config, this.http);
         spyOn(this.http, 'get').and.callThrough();

         target.getAll();

         expect(this.http.get).toHaveBeenCalledWith('http://url');
      });
   });

   describe('getById', () => {
      it('should call to the locations URL with the id', () => {
         const target = new LocationProvider(this.config, this.http);
         spyOn(this.http, 'get').and.callThrough();

         target.getById(1);

         expect(this.http.get).toHaveBeenCalledWith('http://url/1');
      });
   });
});
