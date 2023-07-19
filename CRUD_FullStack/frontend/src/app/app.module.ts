import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CharacterListComponent } from './components/characters/character-list/character-list.component';
import { CharacterAddComponent } from './components/characters/character-add/character-add.component';
import { FormsModule } from '@angular/forms';
import { CharacterEditComponent } from './components/characters/character-edit/character-edit.component';
import { ConfirmModelComponent } from './components/common/confirm-model/confirm-model.component';

@NgModule({
  declarations: [
    AppComponent,
    CharacterListComponent,
    CharacterAddComponent,
    CharacterEditComponent,
    ConfirmModelComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, FormsModule, HttpClientModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
