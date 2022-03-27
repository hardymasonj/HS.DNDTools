import { Component } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { map, shareReplay } from 'rxjs/operators';
import { Character } from '../characters/shared/character';
import { CharacterService } from '../characters/shared/character.service';
import { CharacterListResponse } from '../characters/character-list/character-list-response';

@Component({
  selector: 'app-app-main-nav',
  templateUrl: './app-main-nav.component.html',
  styleUrls: ['./app-main-nav.component.css']
})
export class AppMainNavComponent {
  characters:Character[];
  isHandset$: Observable<boolean> = this.breakpointObserver.observe(Breakpoints.Handset)
    .pipe(
      map(result => result.matches),
      shareReplay()
    );
  constructor(private breakpointObserver: BreakpointObserver, public characterService:CharacterService) {

  }
  ngOnInit(){
    this.characterService.getCharacterList("RandomId").subscribe((x:CharacterListResponse)=> this.handleResponse(x));
  }
  handleResponse(characterResponse: CharacterListResponse){
    this.characters = characterResponse?.characters;
    console.log(this.characters);
  }
}
