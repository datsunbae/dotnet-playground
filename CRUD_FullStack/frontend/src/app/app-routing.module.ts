import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CharacterListComponent } from './components/characters/character-list/character-list.component';
import { CharacterAddComponent } from './components/characters/character-add/character-add.component';
import { CharacterEditComponent } from './components/characters/character-edit/character-edit.component';

const routes: Routes = [
  {
    path: '',
    component: CharacterListComponent,
    title: 'Kimetsu no Yaiba App',
  },
  {
    path: 'characters',
    component: CharacterListComponent,
    title: 'Characters',
  },
  {
    path: 'characters/add',
    component: CharacterAddComponent,
    title: 'Add Characters',
  },
  {
    path: 'characters/edit/:id',
    component: CharacterEditComponent,
    title: 'Edit Characters',
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
