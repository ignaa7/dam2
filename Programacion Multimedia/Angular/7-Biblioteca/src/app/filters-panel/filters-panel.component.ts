import { Component } from '@angular/core';
import { Service } from 'src/service/service.service';

@Component({
  selector: 'filters-panel',
  templateUrl: './filters-panel.component.html',
  styleUrls: ['./filters-panel.component.css']
})
export class FiltersPanelComponent {
  constructor(private service: Service) {}

  applyFilter(filter: string) {
    this.service.getFilteredBooks(filter);
  }
}
