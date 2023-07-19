import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Character, Gender } from 'src/app/models/character.model';
import { CharacterService } from 'src/app/services/character/character.service';

@Component({
  selector: 'app-character-edit',
  templateUrl: './character-edit.component.html',
  styleUrls: ['./character-edit.component.css'],
})
export class CharacterEditComponent implements OnInit {
  genderOptions = [
    { lable: 'Male', value: Gender.Male },
    { lable: 'Female', value: Gender.Female },
    { lable: 'Other', value: Gender.Other },
  ];
  test: any = Object.keys(Gender);
  character: Character = {
    id: '00000000-0000-0000-0000-000000000000',
    name: '',
    gender: Gender.Male,
    birthday: '',
    height: 0,
    weight: 0,
    image: '',
  };
  constructor(
    private characterService: CharacterService,
    private route: ActivatedRoute,
    private router: Router
  ) {}
  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = params.get('id');

        if (id) {
          this.characterService.getCharacter(id).subscribe({
            next: (character) => {
              this.character = character;
            },
          });
        }
      },
    });
  }

  onSubmit() {
    this.characterService
      .updateChracter(this.character.id, this.character)
      .subscribe({
        next: (character) => {
          this.router.navigate(['characters']);
        },
        error: (error) => {
          alert(error.message);
        },
      });
  }
}
