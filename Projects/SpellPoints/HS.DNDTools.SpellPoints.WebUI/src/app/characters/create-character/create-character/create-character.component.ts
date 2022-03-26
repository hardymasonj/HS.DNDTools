import { Component, OnInit } from '@angular/core';
import { Character } from '../../shared/character';
import { CharacterService } from '../../shared/character.service';

@Component({
  selector: 'app-create-character',
  templateUrl: './create-character.component.html',
  styleUrls: ['./create-character.component.css']
})
export class CreateCharacterComponent implements OnInit {
  character: Character;
  constructor(public characterService:CharacterService) {
    this.character = new Character();
  }

  ngOnInit(): void {
  }
  submit(){
    console.log(this.character);
    this.characterService.createCharacter(this.character.name, this.character.level).subscribe(c => this.handleResponse(c));
  }
  handleResponse(character:Character){
    console.log(character);
  }
}
