class tictactoe {
  constructor() {
    this.cross = true;
    this.board = ['', '', '', '', '', '', '', '', ''];
  }
  click(e) {
    this.add(e.target.id);
  }
  add(id) {
    console.log(this.board);
    let box = document.getElementById(id);
    if (box.innerHTML === '') {
      if (this.cross) {
        this.board[id] = 'X';
        box.innerHTML = 'X';
        console.log(this.CheckForWin('X'));
      } else {
        this.board[id] = 'O';
        box.innerHTML = 'O';
        console.log(this.CheckForWin('O'));
      }
      this.cross = !this.cross;
    }
  }
  CheckForWin(player) {
    return (
      this.winsRow(player) ||
      this.winsColumn(player) ||
      this.winsDiagonal(player)
    );
  }

  winsRow(player) {
    return (
      this.allThree(player, 0, 1, 2) ||
      this.allThree(player, 3, 4, 5) ||
      this.allThree(player, 6, 7, 8)
    );
  }

  winsColumn(player) {
    return (
      this.allThree(player, 0, 3, 6) ||
      this.allThree(player, 1, 4, 7) ||
      this.allThree(player, 2, 5, 8)
    );
  }
  winsDiagonal(player) {
    return this.allThree(player, 0, 4, 8) || this.allThree(player, 2, 4, 6);
  }
  allThree(player, cell_one, cell_two, cell_three) {
    console.log(this.board[cell_one]);
    console.log(this.board[cell_two]);
    console.log(this.board[cell_three]);
    return (
      this.board[cell_one] === player &&
      this.board[cell_two] === player &&
      this.board[cell_three] === player
    );
  }
}

// create instance of tictactoe object and attach event listeners
let game = new tictactoe();
document
  .getElementById('container')
  .addEventListener('click', game.click.bind(game));
