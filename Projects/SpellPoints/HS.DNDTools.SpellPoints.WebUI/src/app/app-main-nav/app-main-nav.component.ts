import { Component } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { map, shareReplay } from 'rxjs/operators';
import { Character } from '../characters/shared/character';
import { CharacterService } from '../characters/shared/character.service';

@Component({
  selector: 'app-app-main-nav',
  templateUrl: './app-main-nav.component.html',
  styleUrls: ['./app-main-nav.component.css']
})
export class AppMainNavComponent {
  testCharacter: Character;
  isHandset$: Observable<boolean> = this.breakpointObserver.observe(Breakpoints.Handset)
    .pipe(
      map(result => result.matches),
      shareReplay()
    );
  constructor(private breakpointObserver: BreakpointObserver, public characterService:CharacterService) {
    this.testCharacter = new Character();
    this.characterService.createCharacter("Patrick O'Neil", 5).subscribe(c=> this.testCharacter = c);
  }

}
