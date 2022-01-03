import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

function App() {
  const [people, setPeople] = useState([]);
  useEffect(() => {
    axios.get('http://localhost:5000/api/people').then((response) => {
      console.log(response);
      setPeople(response.data);
    });
  }, []);
  return (
    <div>
      <Header as="h2" icon="users" content="People" />
      <List>
        {people.map((person: any) => (
          <List.Item key={person.id}>{person.name}</List.Item>
        ))}
      </List>
    </div>
  );
}

export default App;
