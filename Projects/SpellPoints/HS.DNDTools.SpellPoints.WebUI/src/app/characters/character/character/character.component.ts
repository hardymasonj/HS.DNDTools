import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CastSpellService } from '../../shared/cast-spell/cast-spell.service';
import { Character } from '../../shared/character';
import { CharacterService } from '../../shared/character.service';

@Component({
  selector: 'app-character',
  templateUrl: './character.component.html',
  styleUrls: ['./character.component.css']
})
export class CharacterComponent implements OnInit {
  character: Character;
  constructor(private castSpellService:CastSpellService, private characterService:CharacterService, private route:ActivatedRoute) {
    this.character = new Character();
  }

  ngOnInit(): void {
    var id:string;
    this.route.params.subscribe(x=> {
      this.setCharacterFromId(x["id"]);
    });
  }
  setCharacterFromId(id:string):void{
    this.characterService.getCharacter(id).subscribe(x=>{
      this.character = x.character;
      console.log(this.character);
    })
  }
  castSpell(level:number){
    this.castSpellService.castSpell(this.character, level).subscribe(x=> this.character = x.character);
  }
}
