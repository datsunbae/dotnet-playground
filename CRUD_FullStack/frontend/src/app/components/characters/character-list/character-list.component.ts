import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Character } from 'src/app/models/character.model';
import { CharacterService } from 'src/app/services/character/character.service';

@Component({
  selector: 'app-character-list',
  templateUrl: './character-list.component.html',
  styleUrls: ['./character-list.component.css'],
})
export class CharacterListComponent implements OnInit {
  characters: Character[] = [];
  itemIdToDelete: string = '';
  constructor(
    private characterService: CharacterService,
    private router: Router
  ) {}
  ngOnInit(): void {
    this.characterService.getAllCharacters().subscribe({
      next: (characters) => {
        this.characters = characters;
      },
    });
  }
  openDeleteConfirmModel(id: string) {
    this.itemIdToDelete = id;
    $('#deleteConfirmationModal').modal('show');
  }

  deleteItem(itemId: string) {
    this.characterService.deleteCharacter(itemId).subscribe({
      next: (data) => {
        window.location.reload();
      },
      error: (err) => {
        console.log(err);
      },
    });
    $('#deleteConfirmationModal').modal('hide');
  }
}
