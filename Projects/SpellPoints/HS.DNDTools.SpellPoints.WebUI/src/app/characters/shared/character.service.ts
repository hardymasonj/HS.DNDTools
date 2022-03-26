import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Character } from './character';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

//reference: https://stackblitz.com/run?file=src%2Fapp%2Fheroes%2Fheroes.service.ts

@Injectable({
  providedIn: 'root'
})
export class CharacterService {
  characterUrl: string = "api/v1/new-character/";
  constructor(private http:HttpClient) { }
  createCharacter(name: string, level:number): Observable<Character> {
    return this.http.get<Character>(this.characterUrl + name + "/" + level.toString());
  }
}
