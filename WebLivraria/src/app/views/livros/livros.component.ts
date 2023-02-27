import { Component, OnInit } from '@angular/core';
import LivrosModel from 'src/app/models/Livro';

@Component({
  selector: 'app-livros',
  templateUrl: './livros.component.html',
  styleUrls: ['./livros.component.css']
})
export class LivrosComponent implements OnInit {
  livros: LivrosModel[] = [{
    id: '',
    title: 'Um estudo',
    subtitle: 'livros',
    resume: "nada",
    gender: [
      "jaca, joao, lisa"
    ],
    pages: 10,
    year: 2023,
    edition: 1,
    nameAuthor: 'Jao',
    namePublisher: 'dkdk'
  }];

  displayedColumns: string[] = ['title', 'subtitle', 'id', 'gender', 'pages', 'year', 'edition', 'author', 'publisher', 'resume', 'actions'];

  constructor() { }

  ngOnInit(): void {
      
  }

  openDialog(livro: LivrosModel) {

  }

  updateLivro(livro: LivrosModel) {

  }

  deleteLivro(id: string) {

  }
}
