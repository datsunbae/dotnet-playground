import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Character } from 'src/app/models/character.model';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root',
})
export class CharacterService {
  apiURL: string = environment.apiUrl;
  constructor(private httpClient: HttpClient) {}

  getAllCharacters(): Observable<Character[]> {
    return this.httpClient.get<Character[]>(this.apiURL + '/api/character');
  }

  getCharacter(id: string): Observable<Character> {
    return this.httpClient.get<Character>(this.apiURL + '/api/character/' + id);
  }

  addCharacter(character: Character): Observable<Character> {
    return this.httpClient.post<Character>(
      this.apiURL + '/api/character/',
      character
    );
  }

  updateChracter(id: string, character: Character): Observable<Character> {
    return this.httpClient.put<Character>(
      this.apiURL + '/api/character/' + id,
      character
    );
  }

  deleteCharacter(id: string): Observable<Character> {
    return this.httpClient.delete<Character>(
      this.apiURL + '/api/character/' + id
    );
  }
}
