import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-confirm-model',
  templateUrl: './confirm-model.component.html',
  styleUrls: ['./confirm-model.component.css'],
})
export class ConfirmModelComponent {
  @Input() itemId: any;
  @Output() deleteConfirmed: EventEmitter<any> = new EventEmitter<any>();

  confirmDelete() {
    this.deleteConfirmed.emit(this.itemId);
  }
}
