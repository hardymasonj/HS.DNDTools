import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateCharacterComponent } from './characters/create-character/create-character/create-character.component';
import { AppMainNavComponent } from './app-main-nav/app-main-nav.component';

const routes: Routes = [
  { path: '', component: AppMainNavComponent, children:[
    { path: 'create-character', component: CreateCharacterComponent }
  ]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
