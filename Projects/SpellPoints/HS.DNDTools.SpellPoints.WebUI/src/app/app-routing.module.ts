import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateCharacterComponent } from './characters/create-character/create-character/create-character.component';
import { AppMainNavComponent } from './app-main-nav/app-main-nav.component';
import { CharacterComponent } from './characters/character/character/character.component';

//https://stackblitz.com/run?file=src%2Fapp%2Fheroes%2Fhero-list%2Fhero-list.component.html this is a good reference for routing

const routes: Routes = [
  { path: '', component: AppMainNavComponent, children:[
    { path: 'create-character', component: CreateCharacterComponent },
    { path: 'character/:id', component: CharacterComponent}
  ]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
