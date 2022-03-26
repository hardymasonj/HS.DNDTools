import { Component, OnInit } from '@angular/core';
import { Character } from '../../shared/character';
import { CharacterService } from '../../shared/character.service';

@Component({
  selector: 'app-character',
  templateUrl: './character.component.html',
  styleUrls: ['./character.component.css']
})
export class CharacterComponent implements OnInit {
  public character: Character;
  constructor(public characterService:CharacterService) {
    this.characterService.createCharacter("Patrick O'Neil", 5).subscribe(c=> this.character = c);
    console.log(this.character);
  }

  ngOnInit(): void {
  }

  currentSpellPoints(): number{
    return this.character.currentSpellPoints;
  }
}
