import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-livros',
  templateUrl: './livros.component.html',
  styleUrls: ['./livros.component.css']
})
export class LivrosComponent implements OnInit {
  livros: LivrosComponent[] = []
  displayedColumns: string[] = ['title', 'subtitle', 'id', 'gender', 'pages', 'year', 'edition', 'author', 'publisher', 'resume'];

  constructor() {}

  ngOnInit(): void {
      
  }
}
