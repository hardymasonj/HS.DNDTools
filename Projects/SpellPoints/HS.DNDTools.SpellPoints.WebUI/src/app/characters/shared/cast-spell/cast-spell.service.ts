import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Character } from '../character';
import { CastSpell } from './cast-spell.module';

@Injectable({
  providedIn: 'root'
})
export class CastSpellService {

  constructor(private httpClient: HttpClient) {

  }
  castSpell(character:Character, spellLevel:number) : Observable<Character>{
    var castSpell:CastSpell = new CastSpell();
    castSpell.character = character;
    castSpell.spellLevel = spellLevel;
    return this.httpClient.post<Character>("api/v1/cast-spell", castSpell);
  }
}
