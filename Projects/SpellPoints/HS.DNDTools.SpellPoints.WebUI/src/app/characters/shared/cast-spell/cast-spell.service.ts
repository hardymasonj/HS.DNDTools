import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Character } from '../character';
import { GetCharacterResponseModel } from '../get-character-response-model';
import { CastSpellResponseModel } from './cast-spell-response-model';
import { CastSpell } from './cast-spell.module';

@Injectable({
  providedIn: 'root'
})
export class CastSpellService {

  constructor(private httpClient: HttpClient) {

  }
  castSpell(character:Character, spellLevel:number) : Observable<CastSpellResponseModel>{
    var castSpell:CastSpell = new CastSpell();
    castSpell.spellPoints = character.currentSpellPoints;
    castSpell.spellLevel = spellLevel;
    return this.httpClient.post<CastSpellResponseModel>("api/v1/cast-spell", castSpell);
  }
}
