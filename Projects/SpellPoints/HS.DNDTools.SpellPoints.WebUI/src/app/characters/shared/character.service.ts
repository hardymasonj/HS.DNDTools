import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Character } from './character';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { CharacterListResponse } from '../character-list/character-list-response';
import { GetCharacterResponseModel } from './get-character-response-model';
import { CreateCharacterResponseModel } from '../create-character-response-model';

//reference: https://stackblitz.com/run?file=src%2Fapp%2Fheroes%2Fheroes.service.ts

@Injectable({
  providedIn: 'root'
})
export class CharacterService {
  constructor(private http:HttpClient) { }
  createCharacter(name: string, level:number): Observable<CreateCharacterResponseModel> {
    return this.http.get<CreateCharacterResponseModel>("api/v1/new-character/" + name + "/" + level.toString());
  }
  getCharacter(id: string): Observable<GetCharacterResponseModel>{
    return this.http.get<GetCharacterResponseModel>("api/v1/character/" + id);
  }
  getCharacterList(id: string): Observable<CharacterListResponse>{
    return this.http.get<CharacterListResponse>("api/v1/character-list/" + id);
    //id is just a placeholder for now, eventually this will drop and instead there will be auth
  }
}
